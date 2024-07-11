using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih11_KonekDbDapper
{
    public class NilaiDal
    {
        private const string connString = "Server=(local); Database=LatihanDb; Trusted_Connection=True;TrustServerCertificate=True";
    
        public IEnumerable<NilaiModel> ListData()
        {
            const string sql = @"SELECT m.MahasiswaName,mk.MataKuliahName,n.Nilai FROM Nilai n 
                                INNER JOIN Mahasiswa m ON n.MahasiswaId = m.MahasiswaId
                                INNER JOIN MataKuliah mk ON n.MataKuliahId = mk.MataKuliahId";

            using var conn = new SqlConnection(connString);
            var ListNilai = conn.Query<NilaiModel>(sql);
            return ListNilai;
        }
    }
}
