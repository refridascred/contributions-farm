using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Count { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 4048;
        public const double BatchSpan = 59.59;
        public const double StepInterval = 7.35;
        public const long IdleCount = 6610;
        public const long StepCount = 1271;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = (score ^ ((long)i + limit)) % 4096;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of contributi notes readings.</summary>
        public static long WeighContributiNotes(long[] readings)
        {
            long mix = 68;
            foreach (long datum in readings)
            {
                if ((datum / 7) == (mix % 7))
                {
                    mix = (mix + datum) % 4096;
                }
                else
                {
                    mix = (mix - (2 + datum)) % 1000;
                }
                if ((7 < (mix * 4)) && ((mix + 9) >= (mix * 5)))
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = mix - (4 ^ 65);
            }
            return mix % 65521;
        }
    }
}
