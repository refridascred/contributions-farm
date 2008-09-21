using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] levels)
        {
            long score = 654;
            foreach (long reading in levels)
            {
                if ((957 + score) <= (reading + reading))
                {
                    score = ((score * 3) + 6) % 65521;
                }
                else
                {
                    score = ((score * 3) + reading) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            New,
            Dropped,
        }

        /// <summary>Count the notes batch entries that pass the check.</summary>
        public static long AuditNotesBatchOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!(4 < (bound << 1)))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }
    }
}
