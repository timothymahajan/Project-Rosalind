/*
Problem 3: Complementing a Strand of DNA
Given: A DNA string s of length at most 1000 bp.
Return: The reverse complement sc of s.
*/

static void Main(string[] args)
{
	Console.WriteLine(REVC("GGTTATTAATGCAGTGTTCGCATAATTACTGCAGCCTGAACTCCAGATGCATCGCTGGGCGTGCCCCAAAGAAAAAGACGGAGTCTGATCCTGTAGTATCGAGATCACGTATCTTCAAGACTTCGATTAATATGGTTTACTGTTTGACCGTTCACCTAAATAACATTTACGACCCACCCCTTCGATCTGAACCCGTATAGATGAAGTTCCCACCAACCGAGTTTCGGTAACCCTTCGTGTATATCTAGCGCGCCTGGTCGTCCCCTTAGCCAGAAACGCAAACACATTGGCCTGCATCTGCTCAAAAAACCTGTCTGGGGTATCCAACTACCTTCGCCGTATCTACCCTCCACTCGTACTGCTGATCTCTTACTCTGGGACTCCACCGATCTTAATGCTCATGACTTATTTGACGTTTCTCTATATGGCAAAAAAAAATAGTTTATCACTCACTCACGGTGAGGGTGCTCATTGCGAATGAAATCGTGTAGCGGTCGACCGCAGGTGTAGGGATACGTTATTGTCCTTAGGTTAACTGTTCGGACACATGACGGGATACCCGGACGAGGGCTCAACTCTTTAGTGATCAGTCCCTCACAGGCTTACATCATATCTGTATTGACGCTGAGAATCCGTTTTTAATGGCAGGCCCAATTTCGTTCCTGAGCCCGTGGAGCAGCGGTACAGGGAGCGGTAATCGGAAGAGCTTGCCAGCACCTTATGTTCACTGTTTTTGTAACTTTACTATCGCATGCTTTGCGTATTACCTATCTAGCTTTGGCGTCCTATAGGCTATGCCTCGCTGGCTGCCCTATCCGCCAGAGTATTAACGCAAACTTATTAGTCAGGATGCGCGTTAGAGAACTCATATGACGGCGACCAATTGGCAGTTAGCCGTCATCGCGGCTGCAACGATCTACTAC"));
	Console.ReadLine();
}

static string REVC(string strDna)
{
	char[] array = strDna.ToCharArray();
	Array.Reverse(array);
	return new String(array).Replace("T", "X").Replace("A", "T").Replace("X", "A").Replace("C", "X").Replace("G", "C").Replace("X", "G");
}
