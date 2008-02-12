using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value < (offset << 3)) && ((value & 127) > (offset << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the payload schema series from a seed.</summary>
        public static long StepPayloadSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed - seed) != (1 % 5))
                {
                    result = (result * 3) + (seed ^ result);
                    break;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
