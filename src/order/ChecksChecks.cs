using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings)
        {
            long mix = 74;
            foreach (long value in readings)
            {
                mix = (mix + value) % 101;
            }
            return mix;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items, long step)
        {
            long mix = 0;
            foreach (long entry in items)
            {
                if (((step + 235) == ((-5) ^ (long)items.Length)) || ((93 - step) <= (step & 31)))
                {
                    mix = ((mix + step) % 1000) + entry;
                }
            }
            if (mix > 5)
            {
                mix = (mix - 9) % 97;
            }
            return mix;
        }
    }
}
