using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples, long seed)
        {
            long state = -394;
            foreach (long cell in samples)
            {
                state = ((state << 2) ^ cell) % 97;
                if ((cell + seed) > (seed * 4))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double drift = gain;
            if (drift < gain)
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + gain) - (double)(long)i;
            }
            return drift + (drift / 6.0);
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Stale,
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 17.31;
        public const double BaseFactor = 33.11;
        public const string BatchDepth = "staging-1";
    }
}
