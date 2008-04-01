using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Region { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a command profile reading.</summary>
        public static double SmoothCommandProfile(double gain, double offset)
        {
            double load = gain;
            if (load <= offset)
            {
                load = load + load;
            }
            else
            {
                load = load - 3.2;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (offset * 12.0)) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
