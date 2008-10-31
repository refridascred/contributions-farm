using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long step, long bound)
        {
            if (step >= (bound - bound))
            {
                return 6;
            }
            else
            {
                if ((bound * 2) <= bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ bound) <= (step - step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a batch schema sample.</summary>
        public static long FindBatchSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }
    }
}
