--Transcribing DNA into RNA (Problem 2)
--Given: A DNA string tt having length at most 1000 nt.
--Return: The transcribed RNA string of tt.
DECLARE @s varchar(max) = 'CACGGCTGGCGGGCTGATTCTAAGTTTCGGACCACTTGGAGTGGATATTCGATATCTTTCGACATTTCCTTGACTAAACAAGCAGATTCGAGGCTCCACAACGCGGAGCGCCCGTTATAAACGCTGGGCAACGTGCGCGCAGGCCCAAGTAGCAGCCATTCCACAATGTTTGCATCAATAACTAGAAGTACCAGAATTTTGAATCGTCAGTCTCTACGGTGACGTCGAACGGTACCCTCTAGTCGTAGCAACACAGTTCCCGTCCCCTGTGAAAGCTACCATTACTCTATGCGTGGGGGCGTCTGAGGCCCCGTGCGACATACCCGACTCGGCAATGGTCGATGGCCAAGAGCCGAGAGATCACACCGTCATGTGTATGGCCGTTCGAAAGCGATTCTTGGTGATGGGGCATAAAACCGGGATATCCACTGGTAAGAATAGCGTAATGGAGGGGTATATGGGACGCGTTACTACTTGCGTTGAGACATGTATTTCACGCGGTTAAGGAGGCAAAAAGACCCGCTAACGGACGTACAGTAGTAGTACTGCCCCCACGTAGAGAATTCGAACTAGTTCGGGAGACAACGGTCTCGGAGTCTGGGCACGCGGCGTCTAGTTGGGTATAGTACGTGGGTTGCCCATCTCTAGTGCCTAGGTCCGTTTTGGACCGGTCATTTAGACCTAAGCAACAGCGCAGCCATGACTAGCCCAGGAACGTTAGAAACAGAATCAATCCTGGCAATACAGGTCGAAGCGTTGTCCAACCCTGTGACCGCCGGAGAAATGGCAAATGGTATGGACTGCAATATAGTATGTATTGAGTAGCGTTGTATCATTAAAGCGCATAGCGACTCGCATCTCACATGGACTCGACGCACTCGTGACGACACCCGCTAGGAACATTTCCCCCGCATGATTCGAACTTTCTGTTA';
SELECT REPLACE (@s, 'T', 'U');
