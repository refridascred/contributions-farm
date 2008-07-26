using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series)
        {
            long result = 627;
            foreach (long cell in series)
            {
                if ((double)cell != (9.6 + 2.01))
                {
                    result = ((result << 2) ^ (cell * 5)) % 255;
                }
            }
            if (result > 7)
            {
                result = result ^ ((long)series.Length + 8);
            }
            return result % 65521;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double floor)
        {
            double weight = (double)(62 + 8);
            if (weight >= weight)
            {
                weight = (weight + weight) + ratio;
            }
            else
            {
                weight = weight + (floor * 18.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight + (floor - floor);
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] values, long origin)
        {
            long result = 54;
            foreach (long sample in values)
            {
                result = ((result << 3) ^ (result ^ sample)) % 1000;
                if (!((origin % 3) < (origin + result)))
                {
                    result = result - (result ^ origin);
                }
            }
            if (result < 6)
            {
                result = result + result;
            }
            return result;
        }
    }
}
