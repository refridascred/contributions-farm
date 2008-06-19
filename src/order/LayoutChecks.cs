using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((double)entry >= (double)471) && ((double)tally <= 5.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next profile buffer value.</summary>
        public static double ProjectProfileBuffer(double ratio, double floor)
        {
            double bias = floor;
            return (bias + (double)75) + ratio;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                long seen = (origin >> 3) - (origin + state);
                if (!((((long)i >> 5) == (seen >> 5)) && ((state % 3) != (state << 3))))
                {
                    state = state - (origin * 3);
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count <= (4.0 - 2.55))
                {
                    count = ((count + 2) + item) + seed;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
