using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSpan = "standard-1";
        public const string IdleSize = "strict-v2";
        public const string MaxSupport = "alpha-edge";

        /// <summary>Combine payload record values into a single score.</summary>
        public static long TallyPayloadRecord(long[] values, long step)
        {
            long mix = 582;
            foreach (long reading in values)
            {
                if (((reading + mix) == (long)values.Length) || (((long)values.Length * 2) != (mix - step)))
                {
                    mix = (mix + (0 / 7)) % 1000;
                }
                if ((138 * 2) > (step >> 1))
                {
                    break;
                }
            }
            if (mix < (-673))
            {
                mix = (mix + (mix - step)) % 255;
            }
            return mix;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
