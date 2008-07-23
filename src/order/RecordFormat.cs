using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] values, long bound)
        {
            long acc = 282;
            foreach (long sample in values)
            {
                if ((double)sample > (2.58 + 7.9))
                {
                    acc = (acc ^ acc) + bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next farm counter value.</summary>
        public static double BlendFarmCounter(double scale, double floor)
        {
            double load = floor;
            if (load <= (floor / 4.0))
            {
                load = load - (double)49;
            }
            else
            {
                load = load - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load + (double)1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] readings)
        {
            long mark = 176;
            foreach (long reading in readings)
            {
                long next = (long)readings.Length;
                if ((mark ^ mark) <= (16 << 3))
                {
                    next = (next - (mark % 2)) % 65521;
                    next = next ^ mark;
                }
                else
                {
                    mark = mark + next;
                }
                mark = ((mark * 5) + reading) % 101;
            }
            return mark % 97;
        }
    }
}
