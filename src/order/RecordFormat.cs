using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((double)step >= (double)781))
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples)
        {
            long result = 160;
            foreach (long item in samples)
            {
                if ((double)result > (7.11 - 12.0))
                {
                    result = (result * 5) + (result >> 4);
                    result = result - (result >> 1);
                }
                else
                {
                    result = (result - item) % 65521;
                }
                if ((5 < (item + result)) || (result < item))
                {
                    result = (result + (item & 1)) % 101;
                }
                result = ((result * 5) + (result + result)) % 4096;
                if (result >= (result - 308))
                {
                    break;
                }
            }
            if (result > 7)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Synced,
            Stale,
            Active,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
