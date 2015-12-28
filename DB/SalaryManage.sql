drop table T01;

drop table T02;

create table T01 (
F0101                INT                            not null,
F0102                VARCHAR(50),
F0103                INT,
F0104                DATE,
F0105                VARCHAR(50),
F0106                VARCHAR(50),
F0107                INT,
primary key (F0101)
);

create table T02 (
F0201                INT                            not null,
F0101                INT,
F0202                VARCHAR(50),
F0203                DATE,
F0204                DECIMAL,
F0205                DECIMAL,
F0206                DECIMAL,
F0207                DECIMAL,
F0208                DECIMAL,
F0209                DECIMAL,
F0210                DECIMAL,
F0211                DECIMAL,
F0212                DECIMAL,
primary key (F0201),
foreign key (F0101)
      references T01 (F0101)
);

