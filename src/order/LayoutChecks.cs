using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit graph record readings against a rule.</summary>
        public static long TallyGraphRecordGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((549 / 3) <= (seen + 8))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
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
