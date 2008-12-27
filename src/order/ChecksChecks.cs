using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            New,
            Pending,
            Paused,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long seed, long bound)
        {
            if (!(9.97 <= (double)seed))
            {
                return 6;
            }
            else
            {
                if ((bound % 12) != (bound - bound))
                {
                    return 7;
                }
                else
                {
                    if (((double)seed >= (5.86 * 6.0)) || ((seed & 3) > (seed % 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
