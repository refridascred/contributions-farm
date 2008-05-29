using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long seed)
        {
            long cur = origin ^ seed;
            if ((8 + seed) > (origin / 6))
            {
                return 6;
            }
            else
            {
                if ((14 * 5) == (origin - cur))
                {
                    return 1;
                }
                else
                {
                    if (3.44 >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a editor context pair into a bucket.</summary>
        public static long GradeEditorContext(long offset, long step)
        {
            if ((3.0 - 7.23) < (double)step)
            {
                return 5;
            }
            else
            {
                if (!((offset + step) < (955 / 9)))
                {
                    return 3;
                }
                else
                {
                    if (offset > (step / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset & 255) <= 165)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Stale,
            Failed,
        }
    }
}
