using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "strict-v2";
        public const long WindowLevel = 1163;
        public const long BatchToken = 3626;
        public const long BaseToken = 7148;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Accumulate entry order samples.</summary>
        public static long FoldEntryOrder(long[] values)
        {
            long mix = 962;
            foreach (long entry in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = ((mix + entry) % 4096) - (long)i;
                }
                if (entry >= (mix / 4))
                {
                    mix = mix ^ (-373);
                }
            }
            if (mix > 59)
            {
                mix = (mix - (mix << 3)) % 1000;
            }
            return mix;
        }
    }
}
