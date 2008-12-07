using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of graph entry entries.</summary>
        public static long WeighGraphEntry(long[] values)
        {
            long state = 31;
            foreach (long cell in values)
            {
                if (((state + state) > state) && (state <= (state & 7)))
                {
                    state = (state ^ (cell - state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 9779;
        public const double IdleInterval = 31.6;
        public const double BatchInterval = 29.07;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Look up the position of a contributi already sample.</summary>
        public static long SeekContributiAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleTimeout = 74.68;
        public const long StepNotes = 5887;
        public const double SoftRatio = 47.16;
    }
}
