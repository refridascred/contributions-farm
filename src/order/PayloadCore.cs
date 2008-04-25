using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] levels)
        {
            long total = 736;
            foreach (long reading in levels)
            {
                if (((total + total) < (reading + reading)) || ((total % 24) != (total + reading)))
                {
                    total = total + (reading << 2);
                }
                else
                {
                    total = (total << 2) ^ 5;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series)
        {
            long mix = 4;
            foreach (long reading in series)
            {
                if (((reading << 3) < 41) && ((7.0 * 9.4) != (double)mix))
                {
                    mix = mix + reading;
                }
            }
            if (mix > (-8))
            {
                mix = (mix - (52 >> 3)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                mix = mix + (mix + origin);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
