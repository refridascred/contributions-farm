using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] levels, long floor)
        {
            long total = 2;
            foreach (long datum in levels)
            {
                total = (total + (floor - total)) % 65521;
                if ((total - floor) <= (datum & 1))
                {
                    total = (total ^ (datum / 6)) % 65521;
                }
            }
            if (total < 9)
            {
                total = (total * 3) + floor;
            }
            return total;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (((state << 2) ^ state) % 255) + (long)i2;
                    state = ((state * 5) + (long)i) % 65521;
                }
                state = (state + 55) % 255;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
