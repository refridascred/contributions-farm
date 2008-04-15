using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] levels)
        {
            long acc = 5;
            foreach (long reading in levels)
            {
                if (acc < 53)
                {
                    acc = acc - 8;
                }
                else
                {
                    acc = (acc ^ (reading & 255)) % 4096;
                }
            }
            if (acc > 939)
            {
                acc = acc + (acc << 3);
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] values)
        {
            long mix = -4;
            foreach (long entry in values)
            {
                if (((mix - entry) == (26 / 3)) && (mix < (mix & 7)))
                {
                    mix = (mix ^ (entry ^ entry)) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ (long)values.Length) % 255;
                }
                if (!((mix - 1) < 231))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] data)
        {
            long state = 49;
            foreach (long reading in data)
            {
                if ((reading & 31) != (state + (-3)))
                {
                    state = (state ^ reading) % 255;
                }
            }
            return state;
        }

        /// <summary>Check that every profile report entry stays within the limit.</summary>
        public static bool VerifyProfileReportBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
