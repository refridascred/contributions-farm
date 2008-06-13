using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a command editor counter forward.</summary>
        public static long IterateCommandEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i < (step + 0))
                {
                    state = ((state << 3) ^ state) % 1000;
                }
                state = ((state * 2) + step) % 101;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                mix = ((mix + ((long)items.Length + mix)) % 255) + cell;
                if ((mix + mix) != (mix & 3))
                {
                    break;
                }
            }
            if (mix < 40)
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix % 65521;
        }
    }
}
