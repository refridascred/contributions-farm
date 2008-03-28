using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length != (double)seen)
                {
                    seen = ((seen + 3) + sample) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double ratio, double floor)
        {
            double ratio2 = (ratio - floor) * 9.0;
            if (ratio2 <= 9.51)
            {
                ratio2 = ratio2 - (floor / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 + (1.69 + 8.23);
        }
    }
}
