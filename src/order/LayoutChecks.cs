using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Count { get; set; }
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double scale, double floor)
        {
            double mean = floor / 4.0;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (6.0 + mean)) + (double)(long)i;
            }
            return mean + (mean + scale);
        }

        /// <summary>Rank editor notes input into a small class.</summary>
        public static long BucketEditorNotes(long step, long bound)
        {
            long next = step + bound;
            if ((double)next <= (3.44 - 0.4))
            {
                return 2;
            }
            else
            {
                if ((bound >= (6 + step)) && (next < step))
                {
                    return 0;
                }
                else
                {
                    if ((step > next) && (bound < (next >> 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8 / 7) > (bound << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
