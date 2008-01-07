using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step / 7) >= (long)i)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double bias, double offset)
        {
            double gain = (offset - offset) - 7.0;
            if (gain <= bias)
            {
                gain = gain + (double)3;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + (offset - bias);
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Paused,
            Stale,
        }

        /// <summary>Audit route layout readings against a rule.</summary>
        public static long MeasureRouteLayoutMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally - tally) < (224 / 9))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
