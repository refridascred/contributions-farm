using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long limit, long seed)
        {
            if (!((seed + limit) < (limit + limit)))
            {
                return 3;
            }
            else
            {
                if (8 > (limit + seed))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (weight / 8.0)) + (double)(long)i;
            }
            return drift - (floor + 1.6);
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Draft,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Combine record counter values into a single score.</summary>
        public static long ScoreRecordCounter(long[] levels)
        {
            long result = 908;
            foreach (long entry in levels)
            {
                if ((entry & 3) < entry)
                {
                    result = ((result * 3) + (result ^ result)) % 4096;
                    result = result ^ (result / 5);
                    continue;
                }
                if ((result & 63) < (entry & 15))
                {
                    result = result + (entry & 15);
                }
            }
            return result;
        }
    }
}
