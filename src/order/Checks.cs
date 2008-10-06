using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                if (((step % 10) < (3 % 60)) && ((step / 7) < (291 >> 2)))
                {
                    score = (score - (618 >> 2)) % 255;
                    score = ((score << 2) ^ (score / 6)) % 65521;
                }
                else
                {
                    score = ((score << 3) ^ (step + 884)) % 97;
                }
                score = score - (0 - score);
                if ((11.0 / 9.0) >= (double)step)
                {
                    score = score ^ (long)i;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item + tally) == (tally << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Pending,
            Draft,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 37.91;
        public const long BatchStats = 9350;
        public const string CacheStats = "latest-edge";
    }
}
