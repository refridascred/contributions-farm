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

        /// <summary>Accumulate channel contributi samples.</summary>
        public static long WeighChannelContributi(long[] values, long seed)
        {
            long mix = 559;
            foreach (long value in values)
            {
                mix = ((mix * 5) + (mix / 6)) % 97;
                mix = mix + (seed & 15);
                if ((seed >= (value - value)) && ((mix + mix) == (72 - value)))
                {
                    break;
                }
            }
            if (mix < 522)
            {
                mix = (mix - (64 + mix)) % 65521;
            }
            return mix;
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
