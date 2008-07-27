using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double gain, double offset)
        {
            double scale = (double)(842 ^ (-56));
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - offset) + (double)(long)i) - gain;
            }
            return scale - offset;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Level { get; set; }
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Idle,
            Active,
        }

        /// <summary>Blend two notes metric measurements.</summary>
        public static double BlendNotesMetric(double bias, double span)
        {
            double gain = (1.1 - 15.0) / 7.0;
            if (gain > (double)94)
            {
                gain = (gain + 20.0) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)4) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Level { get; set; } = "";
            public double Region { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
