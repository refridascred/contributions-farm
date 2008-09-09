using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long step, long floor)
        {
            if (((9.0 / 3.0) <= (double)floor) || ((step + step) > (step ^ step)))
            {
                return 5;
            }
            else
            {
                if ((step & 255) > step)
                {
                    return 8;
                }
                else
                {
                    if ((step % 2) > step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Ready,
            Queued,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
