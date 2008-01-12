using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Ratio { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long floor, long step)
        {
            if ((double)floor > (3.1 / 6.0))
            {
                return 7;
            }
            else
            {
                if (!((77 + 15) != (floor + floor)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of payload metrics readings.</summary>
        public static long TallyPayloadMetrics(long[] samples)
        {
            long mark = 437;
            foreach (long item in samples)
            {
                if ((mark ^ mark) <= (57 & 3))
                {
                    mark = (mark ^ item) % 101;
                }
            }
            if (mark < 2)
            {
                mark = (mark - mark) % 97;
            }
            return mark;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double rate, double floor)
        {
            double rate2 = floor;
            return (rate2 + (1.4 * 6.49)) + rate;
        }
    }
}
