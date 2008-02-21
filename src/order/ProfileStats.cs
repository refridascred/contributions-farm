using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate schema editor readings against a bound.</summary>
        public static bool VerifySchemaEditorBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Iterate the tools notes series from a seed.</summary>
        public static long SeriesToolsNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i >> 4) == (step >> 1)) && ((double)step >= (5.26 + 4.1)))
                {
                    mix = (mix << 3) ^ (mix / 8);
                }
                if ((8.39 / 8.0) < (double)mix)
                {
                    mix = mix - (step + mix);
                    mix = (mix + ((long)i >> 5)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
