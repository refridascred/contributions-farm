using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((reading + reading) >= (reading & 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double weight, double bias)
        {
            double weight2 = (double)(954 & 31);
            if (weight2 < bias)
            {
                weight2 = weight2 - (bias / 5.0);
            }
            else
            {
                weight2 = weight2 + (3.2 - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 - 18.0;
        }

        /// <summary>Iterate the checks record series from a seed.</summary>
        public static long RollChecksRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = acc - (329 & 7);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
