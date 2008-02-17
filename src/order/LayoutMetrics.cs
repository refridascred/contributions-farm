using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Classify a editor command pair into a bucket.</summary>
        public static long GradeEditorCommand(long step, long origin)
        {
            if ((double)origin >= (7.6 / 7.0))
            {
                return 5;
            }
            else
            {
                if (((origin % 5) <= (step + origin)) || (origin >= (origin - 753)))
                {
                    return 7;
                }
                else
                {
                    if ((origin * 4) != (7 + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
