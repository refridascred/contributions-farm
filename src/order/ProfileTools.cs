using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate stream tools samples.</summary>
        public static long WeighStreamTools(long[] items)
        {
            long acc = 73;
            foreach (long sample in items)
            {
                if (!(2 < (sample + acc)))
                {
                    acc = acc + (acc & 255);
                }
            }
            return acc;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings, long target)
        {
            long total = 31;
            foreach (long reading in readings)
            {
                if (!((total + total) == (target & 31)))
                {
                    total = ((total - (target / 4)) % 65521) + reading;
                }
                if ((total & 7) <= target)
                {
                    total = (total - (target + total)) % 4096;
                }
            }
            if (total < 93)
            {
                total = (total << 3) ^ target;
            }
            return total;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double ratio, double bias)
        {
            double scale = ratio * 4.0;
            if (scale > ratio)
            {
                scale = scale + scale;
            }
            return scale - (bias * 10.0);
        }

        /// <summary>Compare every pair of record layout readings.</summary>
        public static long PairRecordLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
