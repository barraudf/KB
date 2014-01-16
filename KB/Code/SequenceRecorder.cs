using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KB.Code
{
    public class SequenceRecorder
    {
        #region private
        private SortedList<DateTime, KeyboardEventInfo> _Sequence;
        private bool _Recording = false;
        private bool _Playing = false;
        #endregion private

        #region get / set
        public bool Recording
        {
            get { return _Recording; }
        }

        public bool Playing
        {
            get { return _Playing; }
        }
        #endregion get / set

        #region constructors
        public SequenceRecorder()
        {
            _Sequence = new SortedList<DateTime, KeyboardEventInfo>();
        }
        #endregion constructors

        public void StartRecording()
        {
            try
            {
                System.Diagnostics.Debug.Assert( _Playing == false, "StartRecording() can't be called while playing");
                _Recording = true;
            }
            catch
            {
                throw;
            }
        }

        public void StopRecording()
        {
            _Recording = false;
        }

        public void Add(KeyboardEventInfo kei)
        {
            try
            {
                System.Diagnostics.Debug.Assert(_Recording == true, "StartRecording() must be called before adding steps");

                if (_Recording == true)
                    _Sequence.Add(DateTime.Now, kei);
            }
            catch
            {
                throw;
            }
        }

        public async Task Play(WindowInfo[] windows)
        {   
            try
            {
                _Playing = true;
                bool firstStep = true;
                DateTime lastStep = DateTime.Now;
                foreach(KeyValuePair<DateTime, KeyboardEventInfo> kvp in _Sequence)
                {
                    if (firstStep == true)
                    {
                        firstStep = false;
                    }
                    else
                    {
                        await Task.Delay( (kvp.Key - lastStep) );
                    }

                    lastStep = kvp.Key;

                    foreach (WindowInfo i in windows)
                    {
                        kvp.Value.Replay(i.Handle);
                        //KB.Forms.frmMain.WriteLog(string.Format("REPLAY : {0} - {1:X} - {2:X}", ((System.Windows.Forms.Keys)kvp.Value.m_Key).ToString(), kvp.Value.m_Msg, kvp.Value.lParam));
                    }
                }

                _Playing = false;
            }
            catch
            {
                throw;
            }
        }
    }
}
