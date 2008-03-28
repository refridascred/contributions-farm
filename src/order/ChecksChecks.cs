using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step ^ step) >= step)
                {
                    state = (state - ((long)i & 255)) % 97;
                }
                else
                {
                    state = (state << 3) ^ (step + (long)i);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of farm batch entries.</summary>
        public static long WeighFarmBatch(long[] levels)
        {
            long total = 747;
            foreach (long entry in levels)
            {
                if (entry > total)
                {
                    total = (total ^ ((-628) << 1)) % 4096;
                }
                else
                {
                    total = total + ((long)levels.Length - 9);
                }
            }
            return total;
        }
    }
}
