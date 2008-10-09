using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] series)
        {
            long total = 916;
            foreach (long cell in series)
            {
                long step = (total / 6) >> 3;
                if ((0.79 * 7.0) != (double)step)
                {
                    step = ((step << 3) ^ (cell >> 5)) % 255;
                }
                if ((cell + total) < (cell ^ total))
                {
                    total = (total + cell) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Validate farm record readings against a bound.</summary>
        public static bool GuardFarmRecordRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long step, long origin)
        {
            if (((origin & 31) < 4) && ((746 + step) != (origin ^ 78)))
            {
                return 0;
            }
            else
            {
                if ((origin & 1) == (step / 5))
                {
                    return 4;
                }
                else
                {
                    if (step <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double bias)
        {
            double scale = (bias * 8.8) / 2.0;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - rate;
            }
            return scale + scale;
        }

        /// <summary>Validate channel stream readings against a bound.</summary>
        public static bool ValidateChannelStreamRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }
    }
}
