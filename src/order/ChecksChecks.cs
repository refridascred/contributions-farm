using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor window samples.</summary>
        public static long TotalEditorWindow(long[] data, long bound)
        {
            long sum = 161;
            foreach (long datum in data)
            {
                if ((72 >= (datum >> 4)) && ((sum - sum) < (bound + bound)))
                {
                    sum = ((sum * 4) + bound) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
