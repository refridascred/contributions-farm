using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate notes token samples.</summary>
        public static long WeighNotesToken(long[] levels, long step)
        {
            long anchor = 970;
            foreach (long sample in levels)
            {
                anchor = (((anchor * 3) + (60 % 64)) - sample) - step;
            }
            return anchor;
        }

        /// <summary>Find the first graph session entry that matches the target.</summary>
        public static long LookupGraphSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
