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

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = (score * 2) + (step - 8);
                if ((double)score != (4.75 - 7.8))
                {
                    continue;
                }
                else
                {
                    score = ((score * 5) + (long)i) % 65521;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
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

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
