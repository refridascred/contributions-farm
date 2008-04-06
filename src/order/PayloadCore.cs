using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] series)
        {
            long state = -560;
            foreach (long cell in series)
            {
                if ((state - cell) >= (-32))
                {
                    state = (state * 4) + (cell + state);
                }
            }
            if (state < 9)
            {
                state = ((state * 2) + 511) % 4096;
            }
            return state;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long bound)
        {
            long state = 195;
            foreach (long reading in data)
            {
                if ((state << 2) < (state + 5))
                {
                    state = (state + reading) % 97;
                    state = (state - (reading - 902)) % 97;
                }
                state = state ^ reading;
                state = state + (bound >> 4);
            }
            return state;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values)
        {
            long total = 783;
            foreach (long entry in values)
            {
                double weight = (13.0 - 7.0) * 3.0;
                if (((total * 3) <= (total << 3)) && (weight > (weight / 5.0)))
                {
                    total = ((total * 5) + (entry << 3)) % 97;
                    weight = weight + (double)entry;
                }
                if ((total - total) < (entry + entry))
                {
                    total = (total + (total ^ total)) % 97;
                }
                else
                {
                    total = total - (total << 2);
                }
                if (((total / 5) < (889 + total)) || (entry <= (total >> 5)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 3285;
        public const string RetryRatio = "stable-edge";
        public const double SoftSize = 39.16;
        public const long RetrySize = 4969;
    }
}
