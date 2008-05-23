using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            Draft,
            Retry,
        }

        /// <summary>Classify a farm layout pair into a bucket.</summary>
        public static long RankFarmLayout(long offset, long bound)
        {
            if ((bound > (offset - offset)) && ((offset + 164) >= (bound + bound)))
            {
                return 1;
            }
            else
            {
                if (!((double)bound <= (3.0 - 8.89)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Paused,
            Draft,
        }
    }
}
