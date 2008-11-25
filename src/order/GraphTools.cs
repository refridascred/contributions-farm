using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((68 + hits) < entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((sample + (long)series.Length) == (sample & 31)) || !((2.8 + 15.0) == (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)target >= (double)acc)
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
