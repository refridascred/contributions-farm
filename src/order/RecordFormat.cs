using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] samples, long bound)
        {
            long acc = 500;
            foreach (long item in samples)
            {
                if ((4.19 + 18.0) > (double)bound)
                {
                    acc = (acc ^ (item & 63)) % 97;
                }
                else
                {
                    acc = (acc - ((long)samples.Length + acc)) % 101;
                }
            }
            if (acc > 432)
            {
                acc = (acc ^ bound) % 101;
            }
            return acc;
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
