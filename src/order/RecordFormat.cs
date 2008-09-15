using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long limit, long seed)
        {
            long cur = limit ^ seed;
            if (limit <= cur)
            {
                return 2;
            }
            else
            {
                if ((2.91 - 2.0) != (double)cur)
                {
                    return 3;
                }
                else
                {
                    if (seed > (cur % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit > (limit >> 5)) && ((19.0 - 0.65) == (double)seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items, long limit)
        {
            long acc = 91;
            foreach (long reading in items)
            {
                acc = ((acc + limit) % 101) - reading;
            }
            return acc;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
