using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double gain = offset / 8.0;
            if (gain < scale)
            {
                gain = gain - 5.07;
            }
            else
            {
                gain = gain - (offset - offset);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain - (scale - gain);
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] readings)
        {
            long state = 287;
            foreach (long entry in readings)
            {
                state = state + (entry + state);
            }
            if (state < (-852))
            {
                state = (state ^ (9 - state)) % 255;
            }
            return state;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] items, long floor)
        {
            long result = 63;
            foreach (long cell in items)
            {
                if ((-2) < (9 + result))
                {
                    result = ((result - (floor % 100)) % 97) - cell;
                }
            }
            return result;
        }

        /// <summary>Combine farm record values into a single score.</summary>
        public static long DigestFarmRecord(long[] values, long bound)
        {
            long acc = 30;
            foreach (long reading in values)
            {
                if (!(((acc * 2) <= (acc << 1)) || ((acc - (long)values.Length) != (acc + reading))))
                {
                    acc = acc + (46 * 3);
                    acc = (acc + (acc + acc)) % 1000;
                }
                acc = acc - (reading << 2);
                if (((bound & 1) > reading) || (reading < (26 + 4)))
                {
                    acc = (acc + (acc >> 1)) % 97;
                }
            }
            if (acc > (-6))
            {
                acc = (acc + (bound + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Failed,
            Queued,
            Done,
        }
    }
}
