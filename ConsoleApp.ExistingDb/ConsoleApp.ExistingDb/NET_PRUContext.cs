using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.ExistingDb
{
    public partial class NET_PRUContext : DbContext
    {
        public NET_PRUContext()
        {
        }

        public NET_PRUContext(DbContextOptions<NET_PRUContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LogRendimiento> LogRendimiento { get; set; }
        public virtual DbSet<RUT_cliente> RUT_clientes { get; set; }

        // Unable to generate entity type for table 'dbo.RUT_cliente'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=SQL_core02_des;Initial Catalog=NET_PRU;Persist Security Info=True;User ID=usr_core;Password=AO.2016");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<LogRendimiento>(entity =>
            {
                entity.ToTable("log_rendimiento");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DatoEjecutado)
                    .HasColumnName("Dato_ejecutado")
                    .HasMaxLength(50);

                entity.Property(e => e.Ejecutor).HasMaxLength(50);

                entity.Property(e => e.FinEjecucion)
                    .HasColumnName("Fin_ejecucion")
                    .HasColumnType("datetime");

                entity.Property(e => e.InicioEjecucion)
                    .HasColumnName("Inicio_ejecucion")
                    .HasColumnType("datetime");
            });
        }
    }
}
