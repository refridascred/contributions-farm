using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] items)
        {
            long anchor = 49;
            foreach (long cell in items)
            {
                anchor = (anchor * 4) + (anchor + anchor);
                if ((anchor - cell) < anchor)
                {
                    anchor = anchor ^ (anchor >> 5);
                }
            }
            if (anchor < (-278))
            {
                anchor = (anchor + (anchor - anchor)) % 1000;
            }
            return anchor;
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
