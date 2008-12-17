using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state * 5) + (201 + (long)i2)) % 4096;
                    state = (state + state) % 97;
                }
                if ((((long)i + (long)i) == ((long)i + limit)) || ((double)state <= 3.2))
                {
                    state = state + (state - state);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the support notes series from a seed.</summary>
        public static long RollSupportNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = state - (step << 2);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 530;
        public const string HardSpan = "local-edge";
        public const double DefaultInterval = 12.41;
        public const string BaseTimeout = "primary-1";

        /// <summary>Audit metric report readings against a rule.</summary>
        public static long CountMetricReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count >= 1.0)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
