using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                if ((reading << 3) >= 5)
                {
                    anchor = ((anchor << 2) ^ ((long)values.Length << 1)) % 1000;
                }
                else
                {
                    anchor = (anchor - (anchor << 1)) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Retry,
            Paused,
            Idle,
            Synced,
        }
    }
}
