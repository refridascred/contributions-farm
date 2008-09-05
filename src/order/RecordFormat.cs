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

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double scale, double floor)
        {
            double scale2 = floor - (scale / 9.0);
            if (scale2 > (scale2 * 16.0))
            {
                scale2 = scale2 - (double)2;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (floor * 6.61)) + (double)(long)i;
            }
            return scale2 - (scale2 - floor);
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
