using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double load = (double)725 / 2.0;
            if (load > bias)
            {
                load = load + load;
            }
            return load - (scale - bias);
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
