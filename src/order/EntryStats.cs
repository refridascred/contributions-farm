using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = carry + (carry / 4);
                if (!(((carry >> 5) >= (carry - 72)) || ((2.04 / 6.0) < (double)(long)i)))
                {
                    carry = (carry - offset) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long floor, long step)
        {
            if (((floor - step) == (floor / 5)) || ((floor & 1) < floor))
            {
                return 8;
            }
            else
            {
                if ((step + floor) == (step % 60))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of window queue readings.</summary>
        public static long WeighWindowQueue(long[] data)
        {
            long acc = 986;
            foreach (long datum in data)
            {
                if ((double)datum <= 9.32)
                {
                    acc = acc + datum;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of support channel readings.</summary>
        public static long CompareSupportChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double gain, double offset)
        {
            double drift = offset * 6.0;
            return drift + (gain + drift);
        }
    }
}
