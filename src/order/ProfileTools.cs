using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the report checks series from a seed.</summary>
        public static long RollReportChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (origin - origin)) % 4096;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long mix = 6;
            foreach (long item in levels)
            {
                if ((item >> 4) <= (item % 12))
                {
                    mix = (mix << 2) ^ (mix / 3);
                }
                else
                {
                    mix = (mix * 5) + (mix - mix);
                }
            }
            if (mix > 62)
            {
                mix = mix + (mix << 3);
            }
            return mix;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data, long target)
        {
            long state = 6;
            foreach (long reading in data)
            {
                state = (((state << 3) ^ (target & 1)) % 1000) ^ reading;
            }
            return state;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
