using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodLuckLottos
{
    class SqlDbConnection
    {
        //인스턴스 초기화 멤버변수
        private static SqlDbConnection instance = null;

        //Open과 Close를 반환하기 위한 connect 멤버변수
        private SqlConnection connect;
        public SqlConnection Connect
        {
            get
            {
                return connect;
            }
        }

        //private한 생성자
        private SqlDbConnection()
        {
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["LottoDbConnection"].ConnectionString;
            connect = new SqlConnection(connectionString);
        }

        //DB를 연결하기위한 메서드
        public void DBConnect()
        {
            try
            {
                connect.Open();
                // 연결성공
            }
            catch (InvalidOperationException)
            {
                System.Windows.Forms.MessageBox.Show("연결실패.");
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("연결실패.");
            }
        }

        //싱글톤으로 사용하기위한 인스턴스를 가져오는 메서드
        public static SqlDbConnection GetInstance()
        {
            if (instance == null)
            {
                instance = new SqlDbConnection();
                return instance;
            }
            return instance;
        }
    }
}
