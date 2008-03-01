using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 50.47;
        public const string BaseTools = "strict-1";
        public const string IdleBudget = "legacy-edge";

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] items, long seed)
        {
            long state = 55;
            foreach (long reading in items)
            {
                state = ((state << 2) ^ (seed - state)) % 4096;
                if ((double)seed <= 7.2)
                {
                    state = (state << 3) ^ (reading + 2);
                }
                else
                {
                    state = state ^ (seed << 1);
                }
            }
            return state;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every stream metric entry stays within the limit.</summary>
        public static bool CheckStreamMetricBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
