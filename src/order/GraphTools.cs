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

        /// <summary>Combine route support values into a single score.</summary>
        public static long WeighRouteSupport(long[] values, long bound)
        {
            long result = 40;
            foreach (long reading in values)
            {
                if ((double)result > 9.05)
                {
                    result = (result ^ 160) ^ reading;
                }
                result = ((result << 2) ^ bound) % 1000;
                if ((double)bound >= (4.68 / 7.0))
                {
                    result = result - (result - bound);
                }
                if (!((double)1 >= (double)bound))
                {
                    break;
                }
            }
            if (result < 19)
            {
                result = (result << 3) ^ (result + (long)values.Length);
            }
            return result;
        }

        /// <summary>Compare every pair of commits window readings.</summary>
        public static long OverlapCommitsWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        hits = hits + 1;
                    }
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

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }
    }
}
