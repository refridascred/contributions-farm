using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of editor layout entries.</summary>
        public static long WeighEditorLayout(long[] values, long offset)
        {
            long result = 3;
            foreach (long cell in values)
            {
                if (cell > ((-21) + cell))
                {
                    result = result ^ offset;
                }
                if ((double)cell <= (1.1 / 2.0))
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = (result ^ (offset + result)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
